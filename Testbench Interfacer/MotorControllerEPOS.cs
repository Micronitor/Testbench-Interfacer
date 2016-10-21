///
/// Motor Controller EPOS
///
/// Created: 06.07.2016
/// Author : Lars Erik Songe Paulsen
///

using System;
using System.Threading;
using System.Windows.Forms;
using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;

/// <summary>
/// Motor Controller uses the EposCmd.Net.dll library.
/// Documentation found in the Documentation folder(EposCmd.Net.chm).
/// </summary>
class MotorControllerEPOS
{

    #region Hall sensor positioning using ProfilePositionMode

    /// <summary>
    /// Lock to prevent multiple simultanious queueries to Motorcontroller.
    /// </summary>
    private static object _deviceLock = new object();

    /// <summary>
    /// Epos device connector.
    /// </summary>
    private DeviceManager _mConnector;

    /// <summary>
    /// The Epos device.
    /// </summary>
    private Device _mEpos;

    /// <summary>
    /// Motor moving status.
    /// True if moving, false if stopped.
    /// </summary>
    private bool _moving;

    /// <summary>
    /// ReadOnly Motor moving status.
    /// True if moving, false if stopped.
    /// </summary>
    public bool moving
    {
        get
        {
            return _moving;
        }
    }

    /// <summary>
    /// External input to immediatly stop.
    /// </summary>
    public bool emergency_stop { get; set; }
        //get
        //{
        //    lock (_deviceLock)
        //    {
        //        return emergency_stop;
        //    }
        //}
        //set
        //{
        //    lock (_deviceLock)
        //    {
        //        emergency_stop = value;
        //    }
        //}

    /// <summary>
    /// Motor speed status.
    /// Exposes current speed for displaying in the interface.
    /// </summary>
    public int speed
    {
        get
        {
            int temp = 0;
            lock (_deviceLock)
            { 
                try
                {
                    temp = _mEpos.Operation.MotionInfo.GetVelocityIs();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return temp;
        }
        /*set
        {
            speed = value;
        }*/
    }

    /// <summary>
    /// Starting position for movement.
    /// </summary>
    private int _zeroPosition; 

    /// <summary>
    /// Motor position status.
    /// </summary>
    /// TODO minor: Why does the NullReferenceExeption keep happening only when 0?
    public int position
    {
        get
        {
            lock (_deviceLock)
            {
                try
                {
                    return _mEpos.Operation.MotionInfo.GetPositionIs() - _zeroPosition;
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
        }
        /*set
        {
            position = value;
        }*/
    }

    /// <summary>
    /// Motor target detection sample rate.
    /// </summary>
    private int _sampleRate;

    /// <summary>
    /// ReadOnly Motor target detection sample rate.
    /// </summary>
    public int sampleRate
    {
        get
        {
            return _sampleRate;
        }
    }

    /// <summary>
    /// Dispose any previous connection.
    /// </summary>
    public void dispose()
    {
        if (_mConnector != null)
        {
            try
            {
                _mConnector.Dispose();
            }
            catch (ObjectDisposedException)
            { }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }

    /// <summary>
    /// Initialize new Motor Controller.
    /// </summary>
    /// <param name="DeviceNr"> Possible reduntant.</param>
    /// TODO minor: Investigate why DeviceNr has to be '1'.
    /// TODO minor: Implement full control over sample rate.
    public int initializeNewMotorController(UInt16 DeviceNr)
    {
        int success = 0;

        lock (_deviceLock)
        {
            try
            {
                dispose();

                _mConnector = new DeviceManager();

                _mEpos = _mConnector.CreateDevice(DeviceNr);

                success = setNewZero();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                success = 0;
            }

            _sampleRate = 1;
        }

        return success;

    }

    /// <summary>
    /// Set new Zero position.
    /// </summary>
    public int setNewZero()
    {
        lock (_deviceLock)
        {
            try
            {
                _zeroPosition = _mEpos.Operation.MotionInfo.GetPositionIs();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }       

    /// <summary>
    /// Set the Motor Controller Velocity and Acceleration for the ProfilePositionMode.
    /// </summary>
    /// <param name="velocity"> Velocity value sent to Motorcontroller.</param>
    /// <param name="acceleration"> Acceleration value sent to Motorcontroller</param>
    /// <param name="deacceleration"> Deacceleration value sent to Motorcontroller.</param>
    public void setMotorControllerVelocityAndAccelleration(UInt32 velocity, UInt32 acceleration, UInt32 deacceleration)
    {
        lock (_deviceLock)
        {
            try
            {
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();
                ppm.SetPositionProfile(velocity, acceleration, deacceleration);
            }
            catch (Exception ex)
            {
                if (ex is DeviceException || ex is OverflowException)
                {
                    MessageBox.Show("Failed to update Velocity, Acceleration and Deacceleration.\nVerify valid value ranges.");
                }
                else if (ex is InvalidOperationException)
                {
                    MessageBox.Show("Invalid Operation.");
                }
                else if (ex is FormatException)
                {
                    MessageBox.Show("Invalid formating.");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    /// <summary>
    /// Enable MotorController functionality.
    /// </summary>
    private void enable()
    {
        lock (_deviceLock)
        {
            try
            {
                StateMachine sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                sm.SetEnableState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    /// <summary>
    /// Disable MotorController functionality.
    /// </summary>
    public void disable()
    {
        lock (_deviceLock)
        {
            try
            {
                StateMachine sm = _mEpos.Operation.StateMachine;
                sm = _mEpos.Operation.StateMachine;

                if (sm.GetFaultState())
                    sm.ClearFault();

                sm.SetDisableState();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    /// <summary>
    /// AbsoluteMove using internal encoder/HALL sensor.
    /// </summary>
    /// <param name="target"> Target Hall sensor position sent to Motorcontroller.</param>
    /// TODO minor: Better exception handling. 
    private void absoluteMoveTo(int target)
    {

        emergency_stop = false;

        lock (_deviceLock)
        {
            try
            {
                ProfilePositionMode ppm = _mEpos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();
                ppm.MoveToPosition(_zeroPosition + target, true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    /// <summary>
    /// AbsoluteMove using internal encoder/Hall sensor with full motor stop.
    /// </summary>
    /// <param name="target"> Target Hall sensor position sent to Motorcontroller.</param>
    /// TODO minor: Better exception handling. 
    public void absoluteMoveToAndStop(int target/*, UInt32 velocity, UInt32 acceleration, UInt32 deacceleration*/)
    {
        enable();
        _moving = true;
        absoluteMoveTo(target);
        //lock (_deviceLock)
        //{
            try
            {
                while (target != position && !emergency_stop)
                {
                    Thread.Sleep(_sampleRate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        //}
        _moving = false;
        disable();
    }

    #endregion

    #region Carrier encoder positioning using ProfileVelocityMode

    /*
    /// <summary>
    /// Current motor position given by carrier encoder.
    /// Requires frequent update from carrier via COMPORT.
    /// </summary>
    private int _currentPosition;

    /// <summary>
    /// Move with velocity using ProfileVelocityMode functions.
    /// </summary>
    /// <param name="targetVelocity"> Velocity in RPM sent to EPOS controller.</param>
    /// TODO minor: Fix redundant statemachine functions.
    /// TODO minor: Better exception handling.
    public void moveWithVelocity(int targetVelocity)
    {
        try
        {
            StateMachine sm = _mEpos.Operation.StateMachine;

            if (sm.GetFaultState())
                sm.ClearFault();

            sm.SetEnableState();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        try
        {
            ProfileVelocityMode pvm = _mEpos.Operation.ProfileVelocityMode;
            pvm.ActivateProfileVelocityMode();

            pvm.MoveWithVelocity(targetVelocity);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// Disable the Motor controller, halting all movement.
    /// </summary>
    /// TODO minor: Better exception handling.
    public void stop()
    {
        try
        {
            StateMachine sm = _mEpos.Operation.StateMachine;

            if (sm.GetFaultState())
                sm.ClearFault();

            sm.SetDisableState();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    /// <summary>
    /// Moves to target position. Requires constant update to currentposition.
    /// Speed is bigger the further away from target.
    /// </summary>
    /// <param name="target"> Target carrier encoder position.</param>
    /// <param name="accuracy"> How close to target before finnished.</param>
    /// TODO major: Fix positioning accuracy.
    public void MoveToPos(int target, int accuracy)
    {
        moving = true;

        if (_currentPosition < (target - accuracy))
        {
            while (_currentPosition < (target - accuracy))
            {
                speed = 60 + Math.Abs(2 * 40 * (target - _currentPosition) / 4096);
                if (speed > 60) speed = 60;
                    
                moveWithVelocity(speed);

            }
            stop();
        }
        else if (_currentPosition > (target + accuracy))
        {
            while (_currentPosition > (target + accuracy))
            {
                speed = 60 + Math.Abs(2 * 40 * (target - _currentPosition) / 4096);
                if (speed > 60) speed = 60;

                moveWithVelocity(-speed);

            }
            stop();
                
        }
        else
        {
            stop();
        }

        moving = false;
    }
    */
    #endregion

}