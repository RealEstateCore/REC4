[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Step_Parameter](../Step_Parameter.md) > [Differential_Pressure_Step_Parameter](.)
# Differential_Pressure_Step_Parameter

**Display name:** Differential Pressure Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Differential_Pressure_Step_Parameter;1

---


## Child interfaces
* [Chilled_Water_Differential_Pressure_Step_Parameter](Chilled_Water_Differential_Pressure_Step_Parameter.md)

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
