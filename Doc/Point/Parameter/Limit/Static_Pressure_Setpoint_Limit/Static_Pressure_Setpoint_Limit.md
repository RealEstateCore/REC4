[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Static_Pressure_Setpoint_Limit](#)
# Static_Pressure_Setpoint_Limit

**Display name:** Static Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Static_Pressure_Setpoint_Limit;1

---


## Child interfaces
* [High_Static_Pressure_Cutout_Setpoint_Limit](High_Static_Pressure_Cutout_Setpoint_Limit.md)
* [Max_Static_Pressure_Setpoint_Limit](Max_Static_Pressure_Setpoint_Limit/Max_Static_Pressure_Setpoint_Limit.md)
* [Min_Static_Pressure_Setpoint_Limit](Min_Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit.md)

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
