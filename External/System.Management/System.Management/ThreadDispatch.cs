using System;
using System.Threading;

namespace System.Management
{
	internal class ThreadDispatch
	{
		private Thread thread;

		private Exception exception;

		private ThreadDispatch.ThreadWorkerMethodWithReturn threadWorkerMethodWithReturn;

		private ThreadDispatch.ThreadWorkerMethodWithReturnAndParam threadWorkerMethodWithReturnAndParam;

		private ThreadDispatch.ThreadWorkerMethod threadWorkerMethod;

		private ThreadDispatch.ThreadWorkerMethodWithParam threadWorkerMethodWithParam;

		private object threadReturn;

		private object threadParams;

		private bool backgroundThread;

		private ApartmentState apartmentType;

		public ApartmentState ApartmentType
		{
			get
			{
				return this.apartmentType;
			}
			set
			{
				this.apartmentType = value;
			}
		}

		public Exception Exception
		{
			get
			{
				return this.exception;
			}
		}

		public bool IsBackgroundThread
		{
			get
			{
				return this.backgroundThread;
			}
			set
			{
				this.backgroundThread = value;
			}
		}

		public object Parameter
		{
			get
			{
				return this.threadParams;
			}
			set
			{
				this.threadParams = value;
			}
		}

		public object Result
		{
			get
			{
				return this.threadReturn;
			}
		}

		public ThreadDispatch(ThreadDispatch.ThreadWorkerMethodWithReturn workerMethod) : this()
		{
			this.InitializeThreadState(null, workerMethod, ApartmentState.MTA, false);
		}

		public ThreadDispatch(ThreadDispatch.ThreadWorkerMethodWithReturnAndParam workerMethod) : this()
		{
			this.InitializeThreadState(null, workerMethod, ApartmentState.MTA, false);
		}

		public ThreadDispatch(ThreadDispatch.ThreadWorkerMethodWithParam workerMethod) : this()
		{
			this.InitializeThreadState(null, workerMethod, ApartmentState.MTA, false);
		}

		public ThreadDispatch(ThreadDispatch.ThreadWorkerMethod workerMethod) : this()
		{
			this.InitializeThreadState(null, workerMethod, ApartmentState.MTA, false);
		}

		private ThreadDispatch()
		{
			this.thread = null;
			this.exception = null;
			this.threadParams = null;
			this.threadWorkerMethodWithReturn = null;
			this.threadWorkerMethodWithReturnAndParam = null;
			this.threadWorkerMethod = null;
			this.threadWorkerMethodWithParam = null;
			this.threadReturn = null;
			this.backgroundThread = false;
			this.apartmentType = ApartmentState.MTA;
		}

		private void DispatchThread()
		{
			this.thread.Start();
			this.thread.Join();
		}

		private void InitializeThreadState(object threadParams, ThreadDispatch.ThreadWorkerMethodWithReturn workerMethod, ApartmentState aptState, bool background)
		{
			this.threadParams = threadParams;
			this.threadWorkerMethodWithReturn = workerMethod;
			this.thread = new Thread(new ThreadStart(this.ThreadEntryPointMethodWithReturn));
			this.thread.SetApartmentState(aptState);
			this.backgroundThread = background;
		}

		private void InitializeThreadState(object threadParams, ThreadDispatch.ThreadWorkerMethodWithReturnAndParam workerMethod, ApartmentState aptState, bool background)
		{
			this.threadParams = threadParams;
			this.threadWorkerMethodWithReturnAndParam = workerMethod;
			this.thread = new Thread(new ThreadStart(this.ThreadEntryPointMethodWithReturnAndParam));
			this.thread.SetApartmentState(aptState);
			this.backgroundThread = background;
		}

		private void InitializeThreadState(object threadParams, ThreadDispatch.ThreadWorkerMethod workerMethod, ApartmentState aptState, bool background)
		{
			this.threadParams = threadParams;
			this.threadWorkerMethod = workerMethod;
			this.thread = new Thread(new ThreadStart(this.ThreadEntryPoint));
			this.thread.SetApartmentState(aptState);
			this.backgroundThread = background;
		}

		private void InitializeThreadState(object threadParams, ThreadDispatch.ThreadWorkerMethodWithParam workerMethod, ApartmentState aptState, bool background)
		{
			this.threadParams = threadParams;
			this.threadWorkerMethodWithParam = workerMethod;
			this.thread = new Thread(new ThreadStart(this.ThreadEntryPointMethodWithParam));
			this.thread.SetApartmentState(aptState);
			this.backgroundThread = background;
		}

		public void Start()
		{
			this.exception = null;
			this.DispatchThread();
			if (this.Exception == null)
			{
				return;
			}
			else
			{
				throw this.Exception;
			}
		}

		private void ThreadEntryPoint()
		{
			try
			{
				this.threadWorkerMethod();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.exception = exception;
			}
		}

		private void ThreadEntryPointMethodWithParam()
		{
			try
			{
				this.threadWorkerMethodWithParam(this.threadParams);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.exception = exception;
			}
		}

		private void ThreadEntryPointMethodWithReturn()
		{
			try
			{
				this.threadReturn = this.threadWorkerMethodWithReturn();
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.exception = exception;
			}
		}

		private void ThreadEntryPointMethodWithReturnAndParam()
		{
			try
			{
				this.threadReturn = this.threadWorkerMethodWithReturnAndParam(this.threadParams);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				this.exception = exception;
			}
		}

		public delegate void ThreadWorkerMethod();

		public delegate void ThreadWorkerMethodWithParam(object param);

		public delegate object ThreadWorkerMethodWithReturn();

		public delegate object ThreadWorkerMethodWithReturnAndParam(object param);
	}
}