using EntityLayer.Enums;

namespace EntityLayer.Entities.Service.ServiceStates
{
	public class OpenState : State
	{
		public override string StateString => ServiceStatus.Open.ToString();

		public override void ChangeStateToCanceled(string reason)
		{
			Service.SetState(new CanceledState(reason));
		}

		public override void ChangeStateToClosed()
		{
			throw new Exception("Cannot change status from open to closed");
		}

		public override void ChangeStateToInProgress()
		{
			if (Service.SpecialistId != null && Service.EmployeeId != null)
			{
				Service.SetState(new InProgressState());
			}
			else
			{
				throw new Exception("Employee or specialist is not set");
			}
		}

		public override void ChangeStateToOpen() { } // Left blank on purpose

		public override void ChangeStateToPostponed(string reason)
		{
			Service.SetState(new PostponedState(reason));
		}

		public override void ChangeStateToResolved()
		{
			throw new Exception("Cannot changed status from open to resolved");
		}
	}
}
