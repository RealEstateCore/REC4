[Point](../../Point.md) > [Sensor](../Sensor.md) > [Speed_Sensor](.)
# Speed_Sensor

**Display name:** Speed Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Speed_Sensor;1

---


## Child interfaces
* [Differential_Speed_Sensor](Differential_Speed_Sensor.md)
* [Motor_Speed_Sensor](Motor_Speed_Sensor.md)
* [Wind_Speed_Sensor](Wind_Speed_Sensor.md)

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
