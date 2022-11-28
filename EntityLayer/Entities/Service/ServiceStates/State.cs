namespace EntityLayer.Entities.Service.ServiceStates
{
	public abstract class State
	{
		protected Service Service;

		void SetService(Service service)
		{
			Service = service;
		}

		public abstract string StateString { get; }
		public abstract void ChangeStateToOpen();
		public abstract void ChangeStateToInProgress();
		public abstract void ChangeStateToResolved();
		public abstract void ChangeStateToClosed();
		public abstract void ChangeStateToPostponed(string reason);
		public abstract void ChangeStateToCanceled(string reason);
	}
}
