[Point](../../Point.md) > [Sensor](../Sensor.md) > [Current_Sensor](.)
# Current_Sensor

**Display name:** Current Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Current_Sensor;1

---


## Child interfaces
* [Load_Current_Sensor](Load_Current_Sensor.md)
* [Motor_Current_Sensor](Motor_Current_Sensor.md)
* [Current_Output_Sensor](Current_Output_Sensor/Current_Output_Sensor.md)

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
