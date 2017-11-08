public class WaitingListNotificationQueue
{
    public long id { get; set; }
    public DateTime dateadd { get; set; }
    public long persid { get; set; }
    public string messtyp { get; set; }
    public string frstnam { get; set; }
    public string lastnam { get; set; }
    public string mobile { get; set; }
    public string email { get; set; }
    public string dftmsgbdy { get; set; }
    public string evntdesc { get; set; }
    public DateTime evntstart { get; set; }
    public DateTime rspndby { get; set; }
    public bool prcssd { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
