using EntityLayer.Entities.Notification.Interface;
using EntityLayer.Entities.Service.ServiceStates;
using EntityLayer.Entities.User;
using EntityLayer.Enums;

namespace EntityLayer.Entities.Service
{
	public class Service : BaseEntity, INotifiable
	{
		public Service()
		{
			State = new OpenState();
		}

		public State State { get; set; }

		public int ClientId { get; set; }
		public Client Client { get; set; }

		public int? SpecialistId { get; set; }
		public Specialist? Specialist { get; set; }

		public int? EmployeeId { get; set; }

		public ServiceType ServiceType { get; set; }

		public string? ServiceDescription { get; set; }

		public string? Notes { get; set; }

		public void SetState(State state)
		{
			State = state;
		}

		public void ChangeStateToOpen()
		{
			State.ChangeStateToOpen();
		}

		public void ChangeStateToInProgress()
		{
			State.ChangeStateToInProgress();
		}

		public void ChangeStateToResolved()
		{
			State.ChangeStateToResolved();
		}

		public void ChangeStateToClosed()
		{
			State.ChangeStateToClosed();
		}

		public void ChangeStateToPostponed(string reason)
		{
			State.ChangeStateToPostponed(reason);
		}

		public void ChangeStateToCanceled(string reason)
		{
			State.ChangeStateToCanceled(reason);
		}
	}
}