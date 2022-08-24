[Point](../../Point.md) > [Sensor](../Sensor.md) > [Adjust_Sensor](.)
# Adjust_Sensor

**Display name:** Adjust Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Adjust_Sensor;1

---


## Child interfaces
* [Temperature_Adjust_Sensor](Temperature_Adjust_Sensor.md)
* [Warm_Cool_Adjust_Sensor](Warm_Cool_Adjust_Sensor.md)

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
