namespace PersonalFinance
{
    public class GetAllAccountInput
    {
        #region Construnctors
        public GetAllAccountInput(long userId)
        {
            UserId = userId;
        }
        public GetAllAccountInput() { }
        #endregion
        #region Properties
        public long UserId { get; set; } 
        #endregion

    }
}