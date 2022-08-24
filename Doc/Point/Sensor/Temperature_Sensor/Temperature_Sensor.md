[Point](../../Point.md) > [Sensor](../Sensor.md) > [Temperature_Sensor](.)
# Temperature_Sensor

**Display name:** Temperature Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Sensor;1

---


## Child interfaces
* [Frost_Sensor](Frost_Sensor.md)
* [Heat_Sink_Temperature_Sensor](Heat_Sink_Temperature_Sensor.md)
* [Natural_Gas_Temperature_Sensor](Natural_Gas_Temperature_Sensor.md)
* [Soil_Temperature_Sensor](Soil_Temperature_Sensor.md)
* [Air_Temperature_Sensor](Air_Temperature_Sensor/Air_Temperature_Sensor.md)
* [Radiant_Panel_Temperature_Sensor](Radiant_Panel_Temperature_Sensor/Radiant_Panel_Temperature_Sensor.md)
* [Water_Temperature_Sensor](Water_Temperature_Sensor/Water_Temperature_Sensor.md)
* [Air_Wet_Bulb_Temperature_Sensor](Air_Temperature_Sensor/Air_Wet_Bulb_Temperature_Sensor/Air_Wet_Bulb_Temperature_Sensor.md)

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
