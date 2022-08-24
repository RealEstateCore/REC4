[Point](../../Point.md) > [Sensor](../Sensor.md) > [Water_Level_Sensor](.)
# Water_Level_Sensor

**Display name:** Water Level Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Water_Level_Sensor;1

---


## Child interfaces
* [Collection_Basin_Water_Level_Sensor](Collection_Basin_Water_Level_Sensor.md)
* [Deionised_Water_Level_Sensor](Deionised_Water_Level_Sensor.md)

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
