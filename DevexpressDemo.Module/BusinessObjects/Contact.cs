using System;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace DevexpressDemo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Contact : Person
    {
        public Contact() { }

        public string WebPageAddress { get; set; }
        public string NickName { get; set; }
        public string SpouseName { get; set; }
        public TitleOfCourtesy TitleOfCourtesy { get; set; }
        public DateTime? Anniversary { get; set; }
        [FieldSize(4096)]
        public String Notes { get; set; }
    }
    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };
}