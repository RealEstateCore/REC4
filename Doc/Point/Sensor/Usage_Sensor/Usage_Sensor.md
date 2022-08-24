[Point](../../Point.md) > [Sensor](../Sensor.md) > [Usage_Sensor](.)
# Usage_Sensor

**Display name:** Usage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Usage_Sensor;1

---


## Child interfaces
* [Energy_Usage_Sensor](Energy_Usage_Sensor.md)
* [Natural_Gas_Usage_Sensor](Natural_Gas_Usage_Sensor.md)
* [Steam_Usage_Sensor](Steam_Usage_Sensor.md)
* [Water_Usage_Sensor](Water_Usage_Sensor/Water_Usage_Sensor.md)

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
