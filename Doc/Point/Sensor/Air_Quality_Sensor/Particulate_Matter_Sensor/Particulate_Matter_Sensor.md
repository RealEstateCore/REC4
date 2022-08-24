[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Air_Quality_Sensor](../Air_Quality_Sensor.md) > [Particulate_Matter_Sensor](.)
# Particulate_Matter_Sensor

**Display name:** Particulate Matter Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Particulate_Matter_Sensor;1

---


## Child interfaces
* [PM10_Sensor](PM10_Sensor/PM10_Sensor.md)
* [PM1_Sensor](PM1_Sensor/PM1_Sensor.md)
* [PM25_Sensor](PM25_Sensor/PM25_Sensor.md)
* [TVOC_Sensor](TVOC_Sensor/TVOC_Sensor.md)

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
