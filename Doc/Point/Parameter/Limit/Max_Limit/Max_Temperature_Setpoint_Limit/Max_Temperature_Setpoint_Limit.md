[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Max_Limit](../Max_Limit.md) > [Max_Temperature_Setpoint_Limit](#)
# Max_Temperature_Setpoint_Limit

**Display name:** Max Temperature Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Temperature_Setpoint_Limit;1

---


## Child interfaces
* [Max_Discharge_Air_Temperature_Setpoint_Limit](Max_Discharge_Air_Temperature_Setpoint_Limit.md)
* [Max_Supply_Air_Temperature_Setpoint_Limit](../../../Temperature_Parameter/Air_Temperature_Setpoint_Limit/Supply_Air_Temperature_Setpoint_Limit/Max_Supply_Air_Temperature_Setpoint_Limit.md)

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
