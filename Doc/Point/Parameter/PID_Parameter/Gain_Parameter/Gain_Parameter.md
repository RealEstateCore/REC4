[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [PID_Parameter](../PID_Parameter.md) > [Gain_Parameter](#)
# Gain_Parameter

**Display name:** Gain Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Gain_Parameter;1

---


## Child interfaces
* [Derivative_Gain_Parameter](Derivative_Gain_Parameter.md)
* [Integral_Gain_Parameter](Integral_Gain_Parameter/Integral_Gain_Parameter.md)
* [Proportional_Gain_Parameter](Proportional_Gain_Parameter/Proportional_Gain_Parameter.md)

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
