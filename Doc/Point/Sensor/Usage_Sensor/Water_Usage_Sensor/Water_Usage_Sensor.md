[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Usage_Sensor](../Usage_Sensor.md) > [Water_Usage_Sensor](#)
# Water_Usage_Sensor

**Display name:** Water Usage Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Usage_Sensor;1

---


## Child interfaces
* [Hot_Water_Usage_Sensor](Hot_Water_Usage_Sensor.md)

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
