﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class CarSize
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CarSize()
    {
        this.Reservations = new HashSet<Reservation>();
        this.Vehicles = new HashSet<Vehicle>();
    }

    public string Size { get; set; }
    public string SizeCode { get; set; }
    public Nullable<double> DailyRate { get; set; }
    public Nullable<double> MileageRate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Reservation> Reservations { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Vehicle> Vehicles { get; set; }
}

public partial class Customer
{
    public string LName { get; set; }
    public string FName { get; set; }
    public string Phone { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Inv_ID { get; set; }
    public string Drivers_License { get; set; }
    public Nullable<System.DateTime> RentalDate { get; set; }
}

public partial class Reservation
{
    public string Confirmation_ID { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public Nullable<System.DateTime> Date { get; set; }
    public string CarSize { get; set; }
    public string Time { get; set; }

    public virtual CarSize CarSize1 { get; set; }
}

public partial class Vehicle
{
    public string Inv_ID { get; set; }
    public string Manuf_Name { get; set; }
    public string Model { get; set; }
    public string CarSize { get; set; }

    public virtual CarSize CarSize1 { get; set; }
}
