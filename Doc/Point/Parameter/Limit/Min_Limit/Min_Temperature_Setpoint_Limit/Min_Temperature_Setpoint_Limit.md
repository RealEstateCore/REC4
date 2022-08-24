[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Min_Limit](../Min_Limit.md) > [Min_Temperature_Setpoint_Limit](#)
# Min_Temperature_Setpoint_Limit

**Display name:** Min Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Temperature_Setpoint_Limit;1

---


## Child interfaces
* [Min_Discharge_Air_Temperature_Setpoint_Limit](Min_Discharge_Air_Temperature_Setpoint_Limit.md)
* [Min_Supply_Air_Temperature_Setpoint_Limit](../../../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Supply_Air_Temperature_Setpoint_Limit/Min_Supply_Air_Temperature_Setpoint_Limit.md)

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
