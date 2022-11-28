using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class InProgressState : State
	{
		public override string StateString => ServiceStatus.InProgress.ToString();

		public override void ChangeStateToCanceled(string reason)
		{
			Service.SetState(new CanceledState(reason));
		}

		public override void ChangeStateToClosed()
		{
			throw new Exception("Cannot change status from in progress to closed");
		}

		public override void ChangeStateToInProgress() { } // Left blank on purpose
		public override void ChangeStateToOpen()
		{
			Service.SetState(new OpenState());
		}

		public override void ChangeStateToPostponed(string reason)
		{
			Service.SetState(new PostponedState(reason));
		}

		public override void ChangeStateToResolved()
		{
			Service.SetState(new ResolvedState());
		}
	}
}
