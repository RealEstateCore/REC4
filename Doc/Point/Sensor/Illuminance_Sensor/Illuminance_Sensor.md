[Point](../../Point.md) > [Sensor](../Sensor.md) > [Illuminance_Sensor](#)
# Illuminance_Sensor

**Display name:** Illuminance Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Illuminance_Sensor;1

---


## Child interfaces
* [Outside_Illuminance_Sensor](Outside_Illuminance_Sensor.md)

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
