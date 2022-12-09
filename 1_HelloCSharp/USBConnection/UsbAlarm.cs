using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Management;
class WMIEvent
{
    public static void WMIEventProc()
    {
        WMIEvent we = new WMIEvent();
        ManagementEventWatcher w = null;
        WqlEventQuery q;
        ManagementOperationObserver observer = new ManagementOperationObserver();
        // Bind to local machine
        ManagementScope scope = new ManagementScope("root\\CIMV2");
        scope.Options.EnablePrivileges = true; //sets required privilege
        try
        {
            q = new WqlEventQuery();
            q.EventClassName = "__InstanceOperationEvent";
            q.WithinInterval = new TimeSpan(0, 0, 3);
            q.Condition = @"TargetInstance ISA 'Win32_DiskDrive' ";

            Console.WriteLine(q.QueryString);
            w = new ManagementEventWatcher(scope, q);

            w.EventArrived += new EventArrivedEventHandler(we.UsbEventArrived);
            w.Start();
            Console.ReadLine(); // block main thread for test purposes
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            w.Stop();
        }
    }
    public void UsbEventArrived(object sender, EventArrivedEventArgs e)
    {
        //Get the Event object and display it
        foreach (PropertyData pd in e.NewEvent.Properties)
        {
            ManagementBaseObject mbo = null;
            if ((mbo = pd.Value as ManagementBaseObject) != null)
            {
                foreach (PropertyData prop in mbo.Properties)
                    Console.WriteLine("{0} - {1}", prop.Name, prop.Value);
            }
        }
    }

}