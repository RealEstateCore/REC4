[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Speed_Setpoint_Limit](#)
# Speed_Setpoint_Limit

**Display name:** Speed Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Speed_Setpoint_Limit;1

---


## Child interfaces
* [Max_Speed_Setpoint_Limit](Max_Speed_Setpoint_Limit.md)
* [Min_Speed_Setpoint_Limit](Min_Speed_Setpoint_Limit.md)

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
