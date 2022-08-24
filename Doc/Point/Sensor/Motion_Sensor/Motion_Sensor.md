[Point](../../Point.md) > [Sensor](../Sensor.md) > [Motion_Sensor](#)
# Motion_Sensor

**Display name:** Motion Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Motion_Sensor;1

---


## Child interfaces
* [PIR_Sensor](../Occupancy_Sensor/PIR_Sensor.md)

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
