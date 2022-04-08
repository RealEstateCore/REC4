using System;

/// <summary>
/// A set of often-used URIs, for easy reference.
/// </summary>
namespace SHACL2DTDL.VocabularyHelper
{
    public static class O2O
    {
        public static readonly Uri included = new Uri("https://karlhammar.com/owl2oas/o2o.owl#included");
        public static readonly Uri endpoint = new Uri("https://karlhammar.com/owl2oas/o2o.owl#endpoint");
    }

    public static class Brick  
    {
        public static readonly Uri Entity = new Uri("https://brickschema.org/schema/Brick#Entity");
    }

    public static class QUDT
    {
        public static readonly Uri Unit = new Uri("http://qudt.org/schema/qudt/Unit");
        public static readonly Uri hasQuantityKind = new Uri("http://qudt.org/schema/qudt/hasQuantityKind");

        public static class UnitNS
        {
            public static readonly Uri A = new Uri("http://qudt.org/vocab/unit/A");
            public static readonly Uri CentiM = new Uri("http://qudt.org/vocab/unit/CentiM");
            public static readonly Uri DEG = new Uri("http://qudt.org/vocab/unit/DEG");
            public static readonly Uri DEG_C = new Uri("http://qudt.org/vocab/unit/DEG_C");
            public static readonly Uri HP = new Uri("http://qudt.org/vocab/unit/HP");
            public static readonly Uri HR = new Uri("http://qudt.org/vocab/unit/HR");
            public static readonly Uri KiloGM = new Uri("http://qudt.org/vocab/unit/KiloGM");
            public static readonly Uri KiloGM_PER_HR = new Uri("http://qudt.org/vocab/unit/KiloGM-PER-HR");
            public static readonly Uri KiloPA = new Uri("http://qudt.org/vocab/unit/KiloPA");
            public static readonly Uri KiloW_HR = new Uri("http://qudt.org/vocab/unit/KiloW-HR");
            public static readonly Uri KiloW = new Uri("http://qudt.org/vocab/unit/KiloW");
            public static readonly Uri L = new Uri("http://qudt.org/vocab/unit/L");
            public static readonly Uri L_PER_SEC = new Uri("http://qudt.org/vocab/unit/L-PER-SEC");
            public static readonly Uri LUX = new Uri("http://qudt.org/vocab/unit/LUX");
            public static readonly Uri M = new Uri("http://qudt.org/vocab/unit/M");
            public static readonly Uri MilliM = new Uri("http://qudt.org/vocab/unit/MilliM");
            public static readonly Uri MIN = new Uri("http://qudt.org/vocab/unit/MIN");
            public static readonly Uri N = new Uri("http://qudt.org/vocab/unit/N");
            public static readonly Uri M_PER_SEC = new Uri("http://qudt.org/vocab/unit/M-PER-SEC");
            public static readonly Uri PSI = new Uri("http://qudt.org/vocab/unit/PSI");
            public static readonly Uri REV_PER_MIN = new Uri("http://qudt.org/vocab/unit/REV-PER-MIN");
            public static readonly Uri V = new Uri("http://qudt.org/vocab/unit/V");
            public static readonly Uri W = new Uri("http://qudt.org/vocab/unit/W");
        }

        public static class QuantityKindNS
        {
            public static readonly Uri AngularVelocity = new Uri("http://qudt.org/vocab/quantitykind/AngularVelocity");
            public static readonly Uri ElectricCurrent = new Uri("http://qudt.org/vocab/quantitykind/ElectricCurrent");
            public static readonly Uri Illuminance = new Uri("http://qudt.org/vocab/quantitykind/Illuminance");
            public static readonly Uri Angle = new Uri("http://qudt.org/vocab/quantitykind/Angle");
            public static readonly Uri Energy = new Uri("http://qudt.org/vocab/quantitykind/Energy");
            public static readonly Uri Force = new Uri("http://qudt.org/vocab/quantitykind/Force");
            public static readonly Uri Power = new Uri("http://qudt.org/vocab/quantitykind/Power");
            public static readonly Uri Length = new Uri("http://qudt.org/vocab/quantitykind/Length");
            public static readonly Uri Mass = new Uri("http://qudt.org/vocab/quantitykind/Mass");
            public static readonly Uri MassFlowRate = new Uri("http://qudt.org/vocab/quantitykind/MassFlowRate");
            public static readonly Uri Pressure = new Uri("http://qudt.org/vocab/quantitykind/Pressure");
            public static readonly Uri Time = new Uri("http://qudt.org/vocab/quantitykind/Time");
            public static readonly Uri Temperature = new Uri("http://qudt.org/vocab/quantitykind/Temperature");
            public static readonly Uri Velocity = new Uri("http://qudt.org/vocab/quantitykind/Velocity");
            public static readonly Uri Voltage = new Uri("http://qudt.org/vocab/quantitykind/Voltage");
            public static readonly Uri Volume = new Uri("http://qudt.org/vocab/quantitykind/Volume");
            public static readonly Uri VolumeFlowRate = new Uri("http://qudt.org/vocab/quantitykind/VolumeFlowRate");
        }

    }


    public static class DTDL
    {
        public static readonly string dtdlContext = "dtmi:dtdl:context;2";
        public static readonly Uri Interface = new Uri("dtmi:dtdl:class:Interface;2");
        public static readonly Uri Property = new Uri("dtmi:dtdl:class:Property;2");
        public static readonly Uri Relationship = new Uri("dtmi:dtdl:class:Relationship;2");
        public static readonly Uri Telemetry = new Uri("dtmi:dtdl:class:Telemetry;2");
        public static readonly Uri Component = new Uri("dtmi:dtdl:class:Component;2");
        public static readonly Uri Object = new Uri("dtmi:dtdl:class:Object;2");
        public static readonly Uri name = new Uri("dtmi:dtdl:property:name;2");
        public static readonly Uri contents = new Uri("dtmi:dtdl:property:contents;2");
        public static readonly Uri displayName = new Uri("dtmi:dtdl:property:displayName;2");
        public static readonly Uri description = new Uri("dtmi:dtdl:property:description;2");
        public static readonly Uri extends = new Uri("dtmi:dtdl:property:extends;2");
        public static readonly Uri maxMultiplicity = new Uri("dtmi:dtdl:property:maxMultiplicity;2");
        public static readonly Uri minMultiplicity = new Uri("dtmi:dtdl:property:minMultiplicity;2");
        public static readonly Uri target = new Uri("dtmi:dtdl:property:target;2");
        public static readonly Uri schema = new Uri("dtmi:dtdl:property:schema;2");
        public static readonly Uri fields = new Uri("dtmi:dtdl:property:fields;2");
        public static readonly Uri Map = new Uri("dtmi:dtdl:class:Map;2");
        public static readonly Uri Enum = new Uri("dtmi:dtdl:class:Enum;2");
        public static readonly Uri EnumValue = new Uri("dtmi:dtdl:class:EnumValue;2");
        public static readonly Uri valueSchema = new Uri("dtmi:dtdl:property:valueSchema;2");
        public static readonly Uri enumValue = new Uri("dtmi:dtdl:property:enumValue;2");
        public static readonly Uri enumValues = new Uri("dtmi:dtdl:property:enumValues;2");
        public static readonly Uri comment = new Uri("dtmi:dtdl:property:comment;2");
        public static readonly Uri writable = new Uri("dtmi:dtdl:property:writable;2");
        public static readonly Uri unit = new Uri("dtmi:dtdl:property:unit;2");
        public static readonly Uri properties = new Uri("dtmi:dtdl:property:properties;2");
        public static readonly Uri mapKey = new Uri("dtmi:dtdl:property:mapKey;2");
        public static readonly Uri mapValue = new Uri("dtmi:dtdl:property:mapValue;2");

        public static readonly Uri _string = new Uri("dtmi:dtdl:instance:Schema:string;2");
        public static readonly Uri _boolean = new Uri("dtmi:dtdl:instance:Schema:boolean;2");
        public static readonly Uri _integer = new Uri("dtmi:dtdl:instance:Schema:integer;2");
        public static readonly Uri _date = new Uri("dtmi:dtdl:instance:Schema:date;2");
        public static readonly Uri _dateTime = new Uri("dtmi:dtdl:instance:Schema:dateTime;2");
        public static readonly Uri _double = new Uri("dtmi:dtdl:instance:Schema:double;2");
        public static readonly Uri _duration = new Uri("dtmi:dtdl:instance:Schema:duration;2");
        public static readonly Uri _float = new Uri("dtmi:dtdl:instance:Schema:float;2");
        public static readonly Uri _long = new Uri("dtmi:dtdl:instance:Schema:long;2");

        
        public static readonly Uri ampere = new Uri("dtmi:standard:unit:ampere;2");
        public static readonly Uri volt = new Uri("dtmi:standard:unit:volt;2");
        public static readonly Uri centimetre = new Uri("dtmi:standard:unit:centimetre;2");
        public static readonly Uri degreeCelsius = new Uri("dtmi:standard:unit:degreeCelsius;2");
        public static readonly Uri degreeOfArc = new Uri("dtmi:standard:unit:degreeOfArc;2");
        public static readonly Uri horsepower = new Uri("dtmi:standard:unit:horsepower;2");
        public static readonly Uri hour = new Uri("dtmi:standard:unit:hour;2");
        public static readonly Uri kilogram = new Uri("dtmi:standard:unit:kilogram;2");
        public static readonly Uri kilogramPerHour = new Uri("dtmi:standard:unit:kilogramPerHour;2");
        public static readonly Uri kilopascal = new Uri("dtmi:standard:unit:kilopascal;2");
        public static readonly Uri kilowattHour = new Uri("dtmi:standard:unit:kilowattHour;2");
        public static readonly Uri kilowatt = new Uri("dtmi:standard:unit:kilowatt;2");
        public static readonly Uri litre = new Uri("dtmi:standard:unit:litre;2");
        public static readonly Uri litrePerSecond = new Uri("dtmi:standard:unit:litrePerSecond;2");
        public static readonly Uri lux = new Uri("dtmi:standard:unit:lux;2");
        public static readonly Uri metre = new Uri("dtmi:standard:unit:metre;2");
        public static readonly Uri metrePerSecond = new Uri("dtmi:standard:unit:metrePerSecond;2");
        public static readonly Uri millimetre = new Uri("dtmi:standard:unit:millimetre;2");
        public static readonly Uri minute = new Uri("dtmi:standard:unit:minute;2");
        public static readonly Uri newton = new Uri("dtmi:standard:unit:newton;2");
        public static readonly Uri poundPerSquareInch = new Uri("dtmi:standard:unit:poundPerSquareInch;2");
        public static readonly Uri revolutionPerMinute = new Uri("dtmi:standard:unit:revolutionPerMinute;2");
        public static readonly Uri watt = new Uri("dtmi:standard:unit:watt;2");
        
        public static readonly Uri Angle = new Uri("dtmi:standard:class:Angle;2");
        public static readonly Uri AngularVelocity = new Uri("dtmi:standard:class:AngularVelocity;2");
        public static readonly Uri Current = new Uri("dtmi:standard:class:Current;2");
        public static readonly Uri Energy = new Uri("dtmi:standard:class:Energy;2");
        public static readonly Uri Force = new Uri("dtmi:standard:class:Force;2");
        public static readonly Uri Illuminance = new Uri("dtmi:standard:class:Illuminance;2");
        public static readonly Uri Voltage = new Uri("dtmi:standard:class:Voltage;2");
        public static readonly Uri Power = new Uri("dtmi:standard:class:Power;2");
        public static readonly Uri Pressure = new Uri("dtmi:standard:class:Pressure;2");
        public static readonly Uri Length = new Uri("dtmi:standard:class:Length;2");
        public static readonly Uri Mass = new Uri("dtmi:standard:class:Mass;2");
        public static readonly Uri MassFlowRate = new Uri("dtmi:standard:class:MassFlowRate;2");
        public static readonly Uri Temperature = new Uri("dtmi:standard:class:Temperature;2");
        public static readonly Uri TimeSpan = new Uri("dtmi:standard:class:TimeSpan;2");
        public static readonly Uri Volume = new Uri("dtmi:standard:class:Volume;2");
        public static readonly Uri Velocity = new Uri("dtmi:standard:class:Velocity;2");
        public static readonly Uri VolumeFlowRate = new Uri("dtmi:standard:class:VolumeFlowRate;2");

    }
}
