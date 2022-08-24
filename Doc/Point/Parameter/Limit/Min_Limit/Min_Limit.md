[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Min_Limit](.)
# Min_Limit

**Display name:** Min Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Limit;1

---


## Child interfaces
* [Min_Chilled_Water_Differential_Pressure_Setpoint_Limit](Min_Chilled_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Hot_Water_Differential_Pressure_Setpoint_Limit](Min_Hot_Water_Differential_Pressure_Setpoint_Limit.md)
* [Min_Fresh_Air_Setpoint_Limit](Min_Fresh_Air_Setpoint_Limit.md)
* [Min_Position_Setpoint_Limit](../Position_Limit/Min_Position_Setpoint_Limit.md)
* [Min_Speed_Setpoint_Limit](../Speed_Setpoint_Limit/Min_Speed_Setpoint_Limit.md)
* [Min_Air_Flow_Setpoint_Limit](Min_Air_Flow_Setpoint_Limit/Min_Air_Flow_Setpoint_Limit.md)
* [Min_Discharge_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Discharge_Air_Static_Pressure_Setpoint_Limit.md)
* [Min_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit.md)
* [Min_Supply_Air_Static_Pressure_Setpoint_Limit](../Static_Pressure_Setpoint_Limit/Min_Static_Pressure_Setpoint_Limit/Min_Supply_Air_Static_Pressure_Setpoint_Limit.md)
* [Min_Temperature_Setpoint_Limit](Min_Temperature_Setpoint_Limit/Min_Temperature_Setpoint_Limit.md)

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
