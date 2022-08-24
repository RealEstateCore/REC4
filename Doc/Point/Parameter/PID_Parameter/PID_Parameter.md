[Point](../../Point.md) > [Parameter](../Parameter.md) > [PID_Parameter](.)
# PID_Parameter

**Display name:** PID Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:PID_Parameter;1

---


## Child interfaces
* [Gain_Parameter](Gain_Parameter/Gain_Parameter.md)
* [Proportional_Band_Parameter](Proportional_Band_Parameter/Proportional_Band_Parameter.md)
* [Step_Parameter](Step_Parameter/Step_Parameter.md)
* [Time_Parameter](Time_Parameter/Time_Parameter.md)

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
