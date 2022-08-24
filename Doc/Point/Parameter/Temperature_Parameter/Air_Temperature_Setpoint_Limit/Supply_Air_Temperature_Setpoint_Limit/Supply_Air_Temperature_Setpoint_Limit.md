[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Air_Temperature_Setpoint_Limit](../Air_Temperature_Setpoint_Limit.md) > [Supply_Air_Temperature_Setpoint_Limit](.)
# Supply_Air_Temperature_Setpoint_Limit

**Display name:** Supply Air Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Setpoint_Limit;1

---


## Child interfaces
* [Max_Supply_Air_Temperature_Setpoint_Limit](Max_Supply_Air_Temperature_Setpoint_Limit.md)
* [Min_Supply_Air_Temperature_Setpoint_Limit](Min_Supply_Air_Temperature_Setpoint_Limit.md)

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
