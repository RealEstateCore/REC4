[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Pressure_Sensor](../Pressure_Sensor.md) > [Static_Pressure_Sensor](.)
# Static_Pressure_Sensor

**Display name:** Static Pressure Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Sensor;1

---


## Child interfaces
* [Building_Air_Static_Pressure_Sensor](Building_Air_Static_Pressure_Sensor.md)
* [Discharge_Air_Static_Pressure_Sensor](Discharge_Air_Static_Pressure_Sensor.md)
* [Supply_Air_Static_Pressure_Sensor](Supply_Air_Static_Pressure_Sensor.md)
* [Underfloor_Air_Plenum_Static_Pressure_Sensor](Underfloor_Air_Plenum_Static_Pressure_Sensor.md)
* [Exhaust_Air_Static_Pressure_Sensor](Exhaust_Air_Static_Pressure_Sensor/Exhaust_Air_Static_Pressure_Sensor.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
