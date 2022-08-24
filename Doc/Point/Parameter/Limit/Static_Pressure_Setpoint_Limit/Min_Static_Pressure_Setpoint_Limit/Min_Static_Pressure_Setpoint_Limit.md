[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit.md) > [Min_Static_Pressure_Setpoint_Limit](#)
# Min_Static_Pressure_Setpoint_Limit

**Display name:** Min Static Pressure Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Static_Pressure_Setpoint_Limit;1

---


## Child interfaces
* [Min_Discharge_Air_Static_Pressure_Setpoint_Limit](Min_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Min_Supply_Air_Static_Pressure_Setpoint_Limit](Min_Supply_Air_Static_Pressure_Setpoint_Limit.md)

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
