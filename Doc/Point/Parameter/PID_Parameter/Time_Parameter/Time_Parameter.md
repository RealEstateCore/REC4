[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [PID_Parameter](../PID_Parameter.md) > [Time_Parameter](.)
# Time_Parameter

**Display name:** Time Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Time_Parameter;1

---


## Child interfaces
* [Derivative_Time_Parameter](Derivative_Time_Parameter.md)
* [Integral_Time_Parameter](Integral_Time_Parameter/Integral_Time_Parameter.md)

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
