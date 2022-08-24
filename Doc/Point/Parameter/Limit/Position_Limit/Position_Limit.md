[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Position_Limit](.)
# Position_Limit

**Display name:** Position Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Limit;1

---


## Child interfaces
* [Max_Position_Setpoint_Limit](Max_Position_Setpoint_Limit.md)
* [Min_Position_Setpoint_Limit](Min_Position_Setpoint_Limit.md)

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
