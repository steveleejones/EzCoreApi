public class SearchRollingAvailabilityLineByDay
{
    public long id { get; set; }
    public long raid { get; set; }
    public short dayno { get; set; }
    public long? abgrp_id { get; set; }
    public string abgrp_mnem { get; set; }
    public long? resreg { get; set; }
    public string resreg_mnem { get; set; }
    public int stime { get; set; }
    public int etime { get; set; }
}
