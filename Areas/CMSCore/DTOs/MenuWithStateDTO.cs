using MarshallStore.Areas.CMSCore.Entities;

namespace MarshallStore.Areas.CMSCore.DTOs
{
    public class MenuWithStateDTO : Menu
    {
        public bool IsSelected { get; set; }
    }
}
