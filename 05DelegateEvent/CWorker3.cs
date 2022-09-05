namespace _05DelegateEvent
{
    public class CWorker3 : INotify
    {
        public event delOnNotify OnNotify;
        public CWorker3()
        {

        }

        public void Test()
        {
            if (OnNotify != null)
            {
                OnNotify();
            }
        }
    }
}
