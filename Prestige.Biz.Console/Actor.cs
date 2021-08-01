namespace Prestige.Biz.Console
{
    public class Actor
    {
        #region [PROPERTIES]
        /// <summary>
        /// Specifies the name of the actor
        /// </summary>
        private string _actorName;
        /// <summary>
        /// Specifies the name of the actor
        /// </summary>
        public string ActorName
        {
            get { return _actorName; }
            set
            {
                if (value.Length > 3)
                {
                    _actorName = value;
                }
                else
                {
                    System.Console.WriteLine("Name should be atleast 3 characters long");
                }
            }
        }

        /// <summary>
        /// Specifies the job title
        /// </summary>
        private string _jobTitle;
        /// <summary>
        /// Specifies the job title
        /// </summary>
        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        /// <summary>
        /// Auto implemented property - Actor Age
        /// </summary>
        public int ActorAge { get; set; }

        /// <summary>
        /// Auto implemented property with assigned value - Actor Desciption
        /// </summary>
        public string ActorDesciption { get; set; } = "Regular Actor";

        /// <summary>
        /// Current Agency of an Actor
        /// </summary>
        private Agency _currentAgency;
        /// <summary>
        /// Current Agency of an Actor
        /// </summary>
        public Agency CurrentAgency
        {
            get
            {
                return _currentAgency;
            }
            set
            {
                _currentAgency = value;
            }
        }


        #endregion

        #region [CONSTRUCTOR]
        /// <summary>
        /// Instance of Actor
        /// </summary>
        public Actor()
        {

        }

        /// <summary>
        ///  Instance of Actor with specified name
        /// </summary>
        /// <param name="actorName"></param>
        public Actor(string actorName) : this()
        {
            ActorName = actorName;
        }
        #endregion

        #region [METHODS]
        /// <summary>
        /// Will return title
        /// </summary>
        public string GetOccupation()
        {
            JobTitle = "Actor";
            return JobTitle;
        }

        /// <summary>
        /// Book an actor without a date.
        /// </summary>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Book an actor with a date.
        /// </summary>
        public string BookActor(string theDate)
        {
            string details = $"Booking for has been succesfully applied.";
            string theActor = $"The actor {ActorName} is booked.";
            if (!string.IsNullOrEmpty(theDate))
            {
                return theActor + "on" + theDate + ". " + details;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Checking if Actor is available to book
        /// </summary>
        /// <param name="actorToBeBooked"></param>
        /// <returns></returns>
        public bool CheckIfActorIsAvailable(Actor actorToBeBooked)
        {
            if (actorToBeBooked.ActorName == "Rikam")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the Actor's Agency's Name
        /// </summary>
        public string GetAgencyName()
        {
            var currentAgency = new Agency();
            return currentAgency.Name;
        }

        /// <summary>
        /// Gets the Actor's Agency with class level property
        /// </summary>
        public string GetAgencyWithProperty()
        {
            return CurrentAgency?.Name;
        }


        #endregion
    }
}
