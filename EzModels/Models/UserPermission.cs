public class UserPermission
{
    public long userPermissionID { get; set; }
    public long user { get; set; }
    public long permission { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
