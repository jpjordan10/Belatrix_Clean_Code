
using System.Collections;

namespace CleanCode.MagicNumbers
{
    public class MagicNumbers
    {
        enum Status { Approve = 1, Denied = 2 };
        public void ApproveDocument(int status)
        {
            if (status == (int)Status.Approve)
            {
                // ...
            }
            else if (status == (int)Status.Denied)
            {
                // ...
            }
        }

        public const string APPROVE = "1";
        public const string DENIED = "2";

        public void RejectDocument(string status)
        {
            switch (status)
            {
                case APPROVE:
                    // ...
                    break;
                case DENIED:
                    // ...
                    break;
            }
        }
    }
}
