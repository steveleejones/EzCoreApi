public class AccessControlDevicesForMachine
{
    public long id { get; set; }
    public long site { get; set; }
    public string mach { get; set; }
    public string desc { get; set; }
    public string ontab { get; set; }
    public byte rdtype { get; set; }
    public string rdport { get; set; }
    public string rddev { get; set; }
    public string swrx { get; set; }
    public byte? swrxgrp { get; set; }
    public byte gttype { get; set; }
    public string gtport { get; set; }
    public string gtdev { get; set; }
    public int gtopen { get; set; }
    public bool enable { get; set; }
    public bool autofac { get; set; }
    public bool autofam { get; set; }
    public short? autotumin { get; set; }
    public short? asktumin { get; set; }
    public byte[] sucwav { get; set; }
    public byte[] failwav { get; set; }
    public byte[] alertwav { get; set; }
    public bool inswipe { get; set; }
    public bool alllowhijack { get; set; }
    public short? accesspriority { get; set; }
    public short? messagepriority { get; set; }
    public short? capturepriority { get; set; }
    public string prepadswipe { get; set; }
    public string postpadswipe { get; set; }
    public long? batch { get; set; }
    public DateTime? lastupd { get; set; }
}
