[Point](../../Point.md) > [Sensor](../Sensor.md) > [Position_Sensor](#)
# Position_Sensor

**Display name:** Position Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Position_Sensor;1

---


## Child interfaces
* [Damper_Position_Sensor](Damper_Position_Sensor.md)
* [Sash_Position_Sensor](Sash_Position_Sensor.md)
* [Valve_Position_Sensor](Valve_Position_Sensor.md)

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
