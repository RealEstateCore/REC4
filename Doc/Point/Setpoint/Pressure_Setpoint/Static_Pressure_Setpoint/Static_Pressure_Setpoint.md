[Point](../../../Point.md) > [Setpoint](../../Setpoint.md) > [Pressure_Setpoint](../Pressure_Setpoint.md) > [Static_Pressure_Setpoint](#)
# Static_Pressure_Setpoint

**Display name:** Static Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Setpoint;1

---


## Child interfaces
* [Building_Air_Static_Pressure_Setpoint](Building_Air_Static_Pressure_Setpoint.md)
* [Chilled_Water_Static_Pressure_Setpoint](Chilled_Water_Static_Pressure_Setpoint.md)
* [Exhaust_Air_Static_Pressure_Setpoint](Exhaust_Air_Static_Pressure_Setpoint.md)
* [Hot_Water_Static_Pressure_Setpoint](Hot_Water_Static_Pressure_Setpoint.md)
* [Underfloor_Air_Plenum_Static_Pressure_Setpoint](Underfloor_Air_Plenum_Static_Pressure_Setpoint.md)
* [Discharge_Air_Static_Pressure_Setpoint](Discharge_Air_Static_Pressure_Setpoint/Discharge_Air_Static_Pressure_Setpoint.md)
* [Static_Pressure_Deadband_Setpoint](Static_Pressure_Deadband_Setpoint/Static_Pressure_Deadband_Setpoint.md)
* [Supply_Air_Static_Pressure_Setpoint](Supply_Air_Static_Pressure_Setpoint/Supply_Air_Static_Pressure_Setpoint.md)

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
