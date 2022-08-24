[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [PID_Parameter](../PID_Parameter.md) > [Step_Parameter](.)
# Step_Parameter

**Display name:** Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Step_Parameter;1

---


## Child interfaces
* [Differential_Pressure_Step_Parameter](Differential_Pressure_Step_Parameter/Differential_Pressure_Step_Parameter.md)
* [Static_Pressure_Step_Parameter](Static_Pressure_Step_Parameter/Static_Pressure_Step_Parameter.md)
* [Temperature_Step_Parameter](Temperature_Step_Parameter/Temperature_Step_Parameter.md)

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
