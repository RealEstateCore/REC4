[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Gain_Parameter](../Gain_Parameter.md) > [Integral_Gain_Parameter](.)
# Integral_Gain_Parameter

**Display name:** Integral Gain Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Integral_Gain_Parameter;1

---


## Child interfaces
* [Discharge_Air_Integral_Gain_Parameter](Discharge_Air_Integral_Gain_Parameter.md)
* [Supply_Air_Integral_Gain_Parameter](Supply_Air_Integral_Gain_Parameter.md)

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
