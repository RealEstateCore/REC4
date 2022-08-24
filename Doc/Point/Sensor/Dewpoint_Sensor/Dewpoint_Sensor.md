[Point](../../Point.md) > [Sensor](../Sensor.md) > [Dewpoint_Sensor](#)
# Dewpoint_Sensor

**Display name:** Dewpoint Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Dewpoint_Sensor;1

---


## Child interfaces
* [Discharge_Air_Dewpoint_Sensor](Discharge_Air_Dewpoint_Sensor.md)
* [Exhaust_Air_Dewpoint_Sensor](Exhaust_Air_Dewpoint_Sensor.md)
* [Outside_Air_Dewpoint_Sensor](Outside_Air_Dewpoint_Sensor.md)
* [Return_Air_Dewpoint_Sensor](Return_Air_Dewpoint_Sensor.md)
* [Supply_Air_Dewpoint_Sensor](Supply_Air_Dewpoint_Sensor.md)
* [Zone_Air_Dewpoint_Sensor](Zone_Air_Dewpoint_Sensor.md)

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
