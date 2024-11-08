using System.Reflection;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System;
using System.Globalization;

namespace Sanita.Utility.ExtendedThread
{
/// <summary>
/// Extends the standard BackgroundWorker Component in .NET 2.0 Winforms
/// To support the ability of aborting the thread the worker it is using
/// </summary>
/// <remarks></remarks> using System;
    public partial class ExBackgroundWorker : BackgroundWorker
    {
        private Thread mThread;
        private ThreadPriority mPriority = ThreadPriority.Normal;

        public ThreadPriority CurrentPriority
        {
            set
            {
                mPriority = value;
                if (mThread != null)
                {
                    mThread.Priority = mPriority;
                }
            }
        }

        public Thread CurrentThread
        {
            get { return mThread; }
            //set { mThread = value; }
        }

        protected override void OnProgressChanged(ProgressChangedEventArgs e)
        {
            if (threadAborted)
                return;
           
            base.OnProgressChanged(e);
        }
        protected override void OnDoWork(DoWorkEventArgs e)
        {
            threadAborted = false;
            mThread = Thread.CurrentThread;
            if (mThread != null)
            {
                mThread.Priority = mPriority;
            }

            mThread.CurrentCulture = SystemInfo.CULTURE_INFO;

            try
            {
                base.OnDoWork(e);
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }

        private bool threadAborted = false;
        public void StopImmediately()
        {
            if (!IsBusy || mThread == null)
            {
                return;
            }
            try
            {
                CancelAsync();
                mThread.Suspend();
                Thread.SpinWait(10);
                mThread.Abort();
            }
            catch (ThreadAbortException)
            {
                //swallow thread abort in this part, even though it will propogate onwards
            }
            catch (Exception ex)
            {
            }
            try
            {
                //OnRunWorkerCompleted(new RunWorkerCompletedEventArgs(null, null, true));
                threadAborted = true;
                //setPrivateFieldValue<bool>("isRunning", false);
                AsyncOperation op = getPrivateFieldValue<AsyncOperation>("asyncOperation");
                SendOrPostCallback completionCallback = getPrivateFieldValue<SendOrPostCallback>("operationCompleted");
                RunWorkerCompletedEventArgs completedArgs = new RunWorkerCompletedEventArgs(null, null, true);
                op.PostOperationCompleted(completionCallback, completedArgs);
            }
            catch (Exception ex)
            {
            }
        }

        

		//type safe reflection
        private FieldType getPrivateFieldValue<FieldType>(string fieldName)
        {
            Type type = typeof(BackgroundWorker);
            FieldInfo field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            object fieldVal = field.GetValue(this);
            
            return safeCastTo<FieldType>(fieldVal);
        }

        private void setPrivateFieldValue<FieldType>(string fieldName,FieldType value)
        {
            Type type = typeof(BackgroundWorker);
            FieldInfo field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(this, value);
            Debug.Assert(field.GetValue(this).Equals( value));
        }

        /// <summary>
        /// Works like a strongly typed "as" operator
        /// If the object is not of the requested type, 
        /// the default value for that type is returns instead of throwing an exception
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private T safeCastTo<T>(object obj)
        {
            if (obj == null)
            {
                return default(T);
            }
            if (!(obj is T))
            {
                return default(T);
            }
            return (T)obj;
        }
    }
}
