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
			_state = new OpenState();
		}

		private State _state { get; set; }

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
			_state = state;
		}

		public void ChangeStateToOpen()
		{
			_state.ChangeStateToOpen();
		}

		public void ChangeStateToInProgress()
		{
			_state.ChangeStateToInProgress();
		}

		public void ChangeStateToResolved()
		{
			_state.ChangeStateToResolved();
		}

		public void ChangeStateToClosed()
		{
			_state.ChangeStateToClosed();
		}

		public void ChangeStateToPostponed(string reason)
		{
			_state.ChangeStateToPostponed(reason);
		}

		public void ChangeStateToCanceled(string reason)
		{
			_state.ChangeStateToCanceled(reason);
		}
	}
}