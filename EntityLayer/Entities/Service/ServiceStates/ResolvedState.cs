using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class ResolvedState : State
	{
		public override string StateString => ServiceStatus.Resolved.ToString();

		public override void ChangeStateToCanceled(string reason)
		{
			Service.SetState(new CanceledState(reason));
		}

		public override void ChangeStateToClosed()
		{
			Service.SetState(new ClosedState());
		}

		public override void ChangeStateToInProgress()
		{
			Service.SetState(new InProgressState());
		}

		public override void ChangeStateToOpen()
		{
			throw new Exception("Cannot change status from resolved to open");
		}

		public override void ChangeStateToPostponed(string reason)
		{
			Service.SetState(new PostponedState(reason));
		}

		public override void ChangeStateToResolved() { } // Left blank on purpose
	}
}
