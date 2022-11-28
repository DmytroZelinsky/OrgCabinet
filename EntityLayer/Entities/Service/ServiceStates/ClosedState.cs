using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class ClosedState : State
	{
		public override string StateString => ServiceStatus.Closed.ToString();

		public override void ChangeStateToCanceled(string reason)
		{
			throw new Exception("Cannot change status from closed to canceled");
		}

		public override void ChangeStateToClosed() { } // Left blank on purpose

		public override void ChangeStateToInProgress()
		{
			throw new Exception("Cannot change status from closed to in progress");
		}

		public override void ChangeStateToOpen()
		{
			throw new Exception("Cannot change status from closed to in open");
		}

		public override void ChangeStateToPostponed(string reason)
		{
			throw new Exception("Cannot change status from closed to in postponed");
		}

		public override void ChangeStateToResolved()
		{
			throw new Exception("Cannot change status from closed to in resolved");
		}
	}
}
