﻿namespace Batch_six.Domain
{
    public class User: BaseModel
    {
       
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public DateTime MembershipDate { get; set; }
        }

    }

