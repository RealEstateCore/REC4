[Point](../../Point.md) > [Sensor](../Sensor.md) > [Humidity_Sensor](#)
# Humidity_Sensor

**Display name:** Humidity Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Sensor;1

---


## Child interfaces
* [Relative_Humidity_Sensor](Relative_Humidity_Sensor/Relative_Humidity_Sensor.md)

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
