using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class CanceledState : State
	{
		public readonly string reasonToCancel;

		public override string StateString => ServiceStatus.Canceled.ToString();

		public CanceledState(string reason)
		{
			reasonToCancel = reason;
		}

		public override void ChangeStateToCanceled(string reason) { } //Left blank on purpose

		public override void ChangeStateToClosed()
		{
			throw new Exception("Cannot change status from canceled to closed");
		}

		public override void ChangeStateToInProgress()
		{
			throw new Exception("Cannot change status from canceled to progress");
		}

		public override void ChangeStateToOpen()
		{
			throw new Exception("Cannot change status from canceled to open");
		}

		public override void ChangeStateToPostponed(string reason)
		{
			throw new Exception("Cannot change status from canceled to postponed");
		}

		public override void ChangeStateToResolved()
		{
			throw new Exception("Cannot change status from canceled to resolved");
		}
	}
}
