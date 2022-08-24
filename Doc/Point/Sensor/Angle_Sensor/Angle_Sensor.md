[Point](../../Point.md) > [Sensor](../Sensor.md) > [Angle_Sensor](#)
# Angle_Sensor

**Display name:** Angle Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Angle_Sensor;1

---


## Child interfaces
* [Solar_Azimuth_Angle_Sensor](Solar_Azimuth_Angle_Sensor.md)
* [Solar_Zenith_Angle_Sensor](Solar_Zenith_Angle_Sensor.md)

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
