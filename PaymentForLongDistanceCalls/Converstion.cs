//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaymentForLongDistanceCalls
{
    using System;
    using System.Collections.Generic;
    
    public partial class Converstion
    {
        public int ConversationID { get; set; }
        public System.DateTime Date { get; set; }
        public string City { get; set; }
        public long ClientPhoneNumber { get; set; }
        public System.TimeSpan Duration { get; set; }
        public bool IsPaid { get; set; }
        public int ClientClientID { get; set; }
        public int ServiceServiceID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }
    }
}