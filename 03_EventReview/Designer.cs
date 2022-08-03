namespace _03_EventReview
{
    internal class Designer
    {
        public delegate void DelFull();
        public event DelFull OnFull;
        int iCount;
        public Designer()
        {
            iCount = 0;
        }

        internal void DesignPlease()
        {
            iCount += 1;
            if (iCount % 5 == 0)
            {
                if(OnFull != null)
                {
                    OnFull();
                }
                else
                {
                    System.Console.WriteLine("이벤트를 등록해주세요");
                }
            }
        }
    }
}
