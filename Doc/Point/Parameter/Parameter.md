[Point](../Point.md) > [Parameter](.)
# Parameter

**Display name:** Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Parameter;1

---


## Child interfaces
* [Alarm_Sensitivity_Parameter](Alarm_Sensitivity_Parameter/Alarm_Sensitivity_Parameter.md)
* [Delay_Parameter](Delay_Parameter/Delay_Parameter.md)
* [Humidity_Parameter](Humidity_Parameter/Humidity_Parameter.md)
* [Limit](Limit/Limit.md)
* [Load_Parameter](Load_Parameter/Load_Parameter.md)
* [PID_Parameter](PID_Parameter/PID_Parameter.md)
* [Temperature_Parameter](Temperature_Parameter/Temperature_Parameter.md)
* [Tolerance_Parameter](Tolerance_Parameter/Tolerance_Parameter.md)

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
