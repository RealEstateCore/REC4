[Point](../../Point.md) > [Sensor](../Sensor.md) > [Energy_Sensor](#)
# Energy_Sensor

**Display name:** Energy Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Energy_Sensor;1

---


## Child interfaces
* [Energy_Usage_Sensor](../Usage_Sensor/Energy_Usage_Sensor.md)
* [Electric_Energy_Sensor](Electric_Energy_Sensor/Electric_Energy_Sensor.md)

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
