[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Air_Flow_Setpoint_Limit](#)
# Air_Flow_Setpoint_Limit

**Display name:** Air Flow Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Setpoint_Limit;1

---


## Child interfaces
* [Max_Air_Flow_Setpoint_Limit](../Max_Limit/Max_Air_Flow_Setpoint_Limit/Max_Air_Flow_Setpoint_Limit.md)
* [Min_Air_Flow_Setpoint_Limit](../Min_Limit/Min_Air_Flow_Setpoint_Limit/Min_Air_Flow_Setpoint_Limit.md)

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
