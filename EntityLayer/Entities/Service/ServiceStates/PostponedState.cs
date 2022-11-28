using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class PostponedState : State
	{
		public readonly string reasonToPostpone;
		public override string StateString => ServiceStatus.Postponed.ToString();

		public PostponedState(string reason)
		{
			reasonToPostpone = reason;
		}

		public override void ChangeStateToCanceled(string reason)
		{
			Service.SetState(new CanceledState(reason));
		}

		public override void ChangeStateToClosed()
		{
			throw new Exception("Cannot change status from postponed to closed");
		}

		public override void ChangeStateToInProgress()
		{
			Service.SetState(new InProgressState());
		}

		public override void ChangeStateToOpen()
		{
			Service.SetState(new OpenState());
		}

		public override void ChangeStateToPostponed(string reason) { } //Left blank on purpose

		public override void ChangeStateToResolved()
		{
			throw new Exception("Cannot change status from postponed to resolved");
		}
	}
}
